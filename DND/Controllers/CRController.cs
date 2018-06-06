using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using DND.Models;

namespace DND.Controllers
{
    class CRController
    {
        private static List<Models.ChallengeRating> CRs;

        static CRController()
        {
            BuildCRList();
        }

        private static void BuildCRList()
        {
            string dataSourceName = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "DnDResources\\ChallengeRatings.json");
            using (StreamReader r = new StreamReader(dataSourceName))
            {
                string json = r.ReadToEnd();
                CRs = JsonConvert.DeserializeObject<List<ChallengeRating>>(json);
            }
        }

        public static ChallengeRating CalculateCR(Creature creature)
        {
            CRController cr = new CRController();
            return cr.CalculateCreatureCR(creature);
        }

        public ChallengeRating CalculateCreatureCR(Creature creature)
        {
            ChallengeRating DefensiveCR = CalculateDefensiveCR(creature);
            ChallengeRating OffensiveCR = CalculateOffensiveCR(creature);

            if (DefensiveCR.CR == OffensiveCR.CR)
                return DefensiveCR;

            int defCRIndex = CRs.FindIndex(x => x.CR == DefensiveCR.CR);
            int offCRIndex = CRs.FindIndex(x => x.CR == OffensiveCR.CR);
            Double avgOfCR = (defCRIndex + offCRIndex) / 2;
            int finalCRIndex = Convert.ToInt32(Math.Round(avgOfCR, 0));
            return CRs[finalCRIndex];
        }

        private ChallengeRating CalculateOffensiveCR(Creature creature)
        {
            int DPR = creature.CalculateDamagePerRound();
            ChallengeRating DmgPerRndCR = CRs.Single(c => c.minDmgPerRnd <= DPR && DPR <= c.maxDmgPerRnd);

            List<ChallengeRating> atkBnsCR = ((List<ChallengeRating>)CRs.Where(c => c.attackBonus <= Int32.Parse(creature.attackBonus) && Int32.Parse(creature.attackBonus) <= c.attackBonus));
            List<ChallengeRating> saveDCCR = ((List<ChallengeRating>)CRs.Where(c => c.saveDC <= Int32.Parse(creature.saveDC) && Int32.Parse(creature.saveDC) <= c.saveDC));

            List<ChallengeRating> secondaryCR;
            if (UseAtkBnsOverSaveDC(creature))
                secondaryCR = atkBnsCR;
            else
                secondaryCR = saveDCCR;

            if (secondaryCR.Contains(DmgPerRndCR) || CRWithin2(DmgPerRndCR, secondaryCR))
                return DmgPerRndCR;
            else
                return AdjustCR(DmgPerRndCR, secondaryCR);
        }
        private bool UseAtkBnsOverSaveDC(Creature creature)
        {
            return (creature.saveDC < creature.attackBonus + 10);
        }
        private ChallengeRating CalculateDefensiveCR(Creature creature)
        {
            ChallengeRating DefensiveCR = CRs.Single(c => c.minHP <= Int32.Parse(creature.hp) && Int32.Parse(creature.hp) <= c.maxHP);
            
            List<ChallengeRating> acCR = ((List<ChallengeRating>)CRs.Where(c => c.AC <= Int32.Parse(creature.ac) && Int32.Parse(creature.ac) <= c.AC));
            if (acCR.Contains(DefensiveCR) || CRWithin2(DefensiveCR, acCR))
                return DefensiveCR;
            else
                return AdjustCR(DefensiveCR, acCR);
            }
        private ChallengeRating AdjustCR(Models.ChallengeRating firstCR, List<ChallengeRating> secondCR)
        {
            ChallengeRating nearestCR;
            if (firstCR.CR < secondCR[0].CR)
                nearestCR = (ChallengeRating)secondCR.Single(a => a.CR == secondCR.Min(x => x.CR));
            else
                nearestCR = (ChallengeRating)secondCR.Single(a => a.CR == secondCR.Max(x => x.CR));

            decimal difference = Math.Abs(CRs.IndexOf(firstCR) - CRs.IndexOf(nearestCR));
            int adjust = Convert.ToInt32(Math.Round(difference / 2, 0));

            return CRs[CRs.IndexOf(firstCR) + adjust];
        }
        private bool CRWithin2(Models.ChallengeRating firstCR, List<ChallengeRating> secondCR)
        {
            foreach(ChallengeRating cr in secondCR)
                if (Math.Abs(CRs.IndexOf(firstCR) - CRs.IndexOf(cr)) <= 2)
                    return true;

            return false;
        }
    }
}
