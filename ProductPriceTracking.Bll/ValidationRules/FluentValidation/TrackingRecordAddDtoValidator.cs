﻿using FluentValidation;

using ProductPriceTracking.Dto.TrackingRecordDtos;

namespace ProductPriceTracking.Bll.ValidationRules.FluentValidation
{
    public class TrackingRecordAddDtoValidator : AbstractValidator<TrackingRecordAddDto>
    {
        public TrackingRecordAddDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Url).NotEmpty().WithMessage("Url alanı boş geçilemez");
            RuleFor(x => x.WebsiteId).InclusiveBetween(1, int.MaxValue).WithMessage("Lütfen geçerli bir website bilgisi seçiniz");
            RuleFor(x => x.ProductId).InclusiveBetween(1, int.MaxValue).WithMessage("Lütfen geçerli bir ürün bilgisi seçiniz");
        }
    }
}
