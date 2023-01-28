using FluentValidation;
using tckimlikdogrulama.Model;

namespace tckimlikdogrulama.Service
{
    public class Validationform: AbstractValidator<signupModel>
    {
        public Validationform() 
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Adınızı boş geçemezsiniz!");
            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Soyadınızı boş geçemezsiniz!");
            RuleFor(x => x.TCKimlikNo).NotEmpty().WithMessage("TC Kimlik numaranızı boş geçemezsiniz!");
            RuleFor(x => x.TCKimlikNo).NotEqual(0).WithMessage("TC Kimlik numaranızı boş geçemezsiniz!");
            RuleFor(x => x.DogumYili).NotEmpty().WithMessage("Doğum yılınızı boş geçemezsiniz!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email adresinizi boş geçemezsiniz!");
            RuleFor(x => x.metamaskaddress).NotEmpty().WithMessage("Metamask Adresinizi boş geçemezsiniz!");
            RuleFor(x => x.metamaskaddress).NotEqual("----").WithMessage("Metamask tarayıcınıza kurulu değil!");

        }
    }
}
