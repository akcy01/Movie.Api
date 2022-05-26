using FluentValidation;
using MovieApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Core.Validation
{
    public class MovieValidator : AbstractValidator<MovieModel>
    {
        public MovieValidator()
        {
            RuleFor(x => x.MovieName).NotEmpty();
            RuleFor(x => x.PublishYear).LessThan(2022);
            
        }
    }
}
