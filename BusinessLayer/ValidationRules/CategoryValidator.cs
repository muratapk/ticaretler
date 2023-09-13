using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        { 
         RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Bu Alanı Boş Geçmezsiniz");
         RuleFor(x => x.CategoryName).Null().WithMessage("Bu Alanı Boş Geçmezsiniz");        
        }
    }
}
