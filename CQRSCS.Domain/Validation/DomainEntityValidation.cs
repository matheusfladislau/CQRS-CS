namespace CQRSCS.Domain.Validation; 

public class DomainEntityValidation : Exception  {
    public DomainEntityValidation(string error) : base(error) { }

    public static void When(bool hasError, string error) {
        if (hasError) {
            throw new DomainEntityValidation(error);
        }
    }
}
