using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GAG.Models.Gag
{
    public class SchoolBudgetShareModel : BaseModel
    {
        public int KeyStage1Pupils { get; set; }
        public decimal KeyStage1Rate { get; set; }
        public decimal KeyStage1Total { get; set; }

        public int KeyStage2Pupils { get; set; }
        public decimal KeyStage2Rate { get; set; }
        public decimal KeyStage2Total { get; set; }

        public int KeyStage3Pupils { get; set; }
        public decimal KeyStage3Rate { get; set; }
        public decimal KeyStage3Total { get; set; }

        public int KeyStage4Pupils { get; set; }
        public decimal KeyStage4Rate { get; set; }
        public decimal KeyStage4Total { get; set; }

        public int DeprivationSecondaryIdaciFPupils { get; set; }
        public decimal DeprivationSecondaryIdaciFRate { get; set; }
        public decimal DeprivationSecondaryIdaciFTotal { get; set; }

        public int DeprivationSecondaryIdaciEPupils { get; set; }
        public decimal DeprivationSecondaryIdaciERate { get; set; }
        public decimal DeprivationSecondaryIdaciETotal { get; set; }

        public int DeprivationSecondaryIdaciDPupils { get; set; }
        public decimal DeprivationSecondaryIdaciDRate { get; set; }
        public decimal DeprivationSecondaryIdaciDTotal { get; set; }

        public int DeprivationSecondaryFsmPupils { get; set; }
        public decimal DeprivationSecondaryFsmRate { get; set; }
        public decimal DeprivationSecondaryFsmTotal { get; set; }

        public int EngishAddSecondaryEalPupils { get; set; }
        public decimal EngishAddSecondaryEalRate { get; set; }
        public decimal EngishAddSecondaryEalTotal { get; set; }

        public int SecondaryLumpSumPupils { get; set; }
        public decimal SecondaryLumpSumRate { get; set; }
        public decimal SecondaryLumpSumTotal { get; set; }

        public decimal TotalPupilLedfactors { get; set; }
        public decimal TotalOtherFactors { get; set; }
        public decimal TotalSchoolBudgetShare { get; set; }
    }
}