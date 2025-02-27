﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRO.Domain.Query.Review
{ 
    public class SearchReviewsQueryValidator : AbstractValidator<SearchReviewsQuery>
    {
        public SearchReviewsQueryValidator()
        {
            RuleFor(n => n).Custom((value, context) =>
            {
                if (value.PageNumber < 1)
                    context.AddFailure("PageNumber", "Page number has to be greater than 0");
                if (value.PageSize < 0)
                    context.AddFailure("PageNumber", "Page size must be greater than 0");
            });
        }
    }
}
