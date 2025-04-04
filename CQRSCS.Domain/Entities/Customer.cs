using CQRSCS.Domain.Validation;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace CQRSCS.Domain.Entities {
    public sealed class Customer : Entity {
        public Customer(string name, string email,
            DateTime? birthDate) {

            ValidateName(name);
            ValidateEmail(email);
            ValidateBirthDate(birthDate);

            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
        }

        public Customer(int id, string name, string email,
            DateTime? birthDate) {

            ValidateId(id);
            ValidateName(name);
            ValidateEmail(email);
            ValidateBirthDate(birthDate);

            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime? BirthDate { get; private set; }

        
        public void Update(string name, string email,
            DateTime? birthDate) {

            ValidateName(name);
            ValidateEmail(email);
            ValidateBirthDate(birthDate);

            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
        }

        private void ValidateId(int id) {
            DomainEntityValidation.When(id < 0,
                "Error: id must be positive.");
        }
        private void ValidateName(string name) {
            DomainEntityValidation.When(string.IsNullOrEmpty(name),
                "Error: name is required.");
        }
        private void ValidateEmail(string email) {
            DomainEntityValidation.When(string.IsNullOrEmpty(email),
                "Error: email is required.");

            DomainEntityValidation.When(!new EmailAddressAttribute().IsValid(email),
                "Error: email is invalid.");
        }
        private void ValidateBirthDate(DateTime? birthDate) {
            DomainEntityValidation.When(birthDate == null,
                "Error: birth date is required.");
        }
    }
}
