﻿using stockInfoApi.DAL.Models.ResponseDtos;
using stockInfoApi.Models.AccountDtos;
using static stockInfoApi.DAL.Enums.Enums;

namespace stockInfoApi.DAL.Validations
{
    public class DtoValidations
    {
        public static ValidationCheck ValidPutAccountDto (PutAccountDto req)
        {
            var email = PropertyValidations.ValidEmail(req.EmailAddress);
            var nickname = PropertyValidations.ValidNickname(req.Nickname);
            var accountType = AccountTypeIsValid((int)req.AccountType);
            if (!email)
                return new ValidationCheck(true, "Invalid email address");
            else if (!nickname)
                return new ValidationCheck(true, "Nickname can only contain letters and numbers");
            else if (!accountType)
                return new ValidationCheck(true, "Invalid account type");
            else
                return new ValidationCheck(false, ""); 
        }

        public static ValidationCheck ValidPostAccountDto (PostAccountDto req)
        {
            var email = PropertyValidations.ValidEmail(req.EmailAddress);
            var nickname = PropertyValidations.ValidNickname(req.Nickname);
            var accountType = AccountTypeIsValid((int)req.AccountType);
            if (!email)
                return new ValidationCheck(true, "Invalid email address");
            else if (!nickname)
                return new ValidationCheck(true, "Nickname can only contain letters and numbers");
            else if (!accountType)
                return new ValidationCheck(true, "Invalid account type");
            else
                return new ValidationCheck(false, "");
        }
    }
}
