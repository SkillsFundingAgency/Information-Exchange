namespace GAG.Core.Domain.Gag
{
    public class SchoolBudgetShare
    {
        public AgeWeightedPupilList AgeWeightedPupilList { get; set; }

        public Deprivation Deprivation { get; set; }

        public SchoolBudgetShareRating EnglishAdditionalLang { get; set; }

        public decimal SecondaryLumpSum { get; set; }

        public decimal TotalPupilLedfactors { get; set; }
        public decimal TotalOtherFactors { get; set; }
        public decimal TotalSchoolBudgetShare { get; set; }
    }
}
