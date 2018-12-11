﻿using System;
using System.Threading.Tasks;
namespace Plugin.FirebaseAuth
{
    public interface IPhoneAuthProvider
    {
        string ProviderId { get; }
        string PhoneSignInMethod { get; }
        IPhoneAuthCredential GetCredential(IAuth auth, string verificationId, string verificationCode);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberAsync(IAuth auth, string phoneNumber);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberForTestingAsync(IAuth auth, string phoneNumber, string verificationCode);
    }
}
