namespace GAG.Core.Domain.Gag
{
    public class AllocationResult
    {
        public AllocationLine AllocationLine { get; set; }

        public int AllocationVersionNumber { get; set; }

        public string AllocationStatus { get; set; }

        public double AllocationAmount { get; set; }

        public int AllocationLearnerCount { get; set; }
    }
}
