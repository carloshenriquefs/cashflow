﻿using CashFlow.Application.UseCases.Expenses.Register;
using CommonTestUtilities.Requests;
using FluentAssertions;
using Shouldly;

namespace Validators.Tests.Expenses.Register
{
    public class RegisterExpenseValidatorTests
    {

        [Fact]
        public void Success()
        {
            // Arrange
            var validator = new RegisterExpenseValidator();
            var request = RequestRegisterExpenseJsonBuilder.Build();

            // Act
            var result = validator.Validate(request);   

            // Assert
            result.IsValid.Should().BeTrue();
            result.IsValid.ShouldBeTrue(); 
        }
    }
}
