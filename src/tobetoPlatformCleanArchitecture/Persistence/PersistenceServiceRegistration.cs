using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BaseDbContext>(options => options.UseInMemoryDatabase("nArchitecture"));
        services.AddScoped<IEmailAuthenticatorRepository, EmailAuthenticatorRepository>();
        services.AddScoped<IOperationClaimRepository, OperationClaimRepository>();
        services.AddScoped<IOtpAuthenticatorRepository, OtpAuthenticatorRepository>();
        services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserOperationClaimRepository, UserOperationClaimRepository>();

        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<ICityRepository, CityRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
        services.AddScoped<IAddressRepository, AddressRepository>();
        services.AddScoped<IDistrictRepository, DistrictRepository>();
        services.AddScoped<ICapabilityRepository, CapabilityRepository>();
        services.AddScoped<IAccountCapabilityRepository, AccountCapabilityRepository>();
        services.AddScoped<IForeignLanguageLevelRepository, ForeignLanguageLevelRepository>();
        services.AddScoped<IForeignLanguageRepository, ForeignLanguageRepository>();
        services.AddScoped<IAccountForeignLanguageMetadataRepository, AccountForeignLanguageMetadataRepository>();
        services.AddScoped<ICertificateRepository, CertificateRepository>();
        services.AddScoped<IAccountCertificateRepository, AccountCertificateRepository>();
        services.AddScoped<ISocialMediaPlatformRepository, SocialMediaPlatformRepository>();
        services.AddScoped<IAccountSocialMediaPlatformRepository, AccountSocialMediaPlatformRepository>();
        services.AddScoped<IGraduationStatusRepository, GraduationStatusRepository>();
        services.AddScoped<ICollegeRepository, CollegeRepository>();
        services.AddScoped<IEducationProgramRepository, EducationProgramRepository>();
        services.AddScoped<IAccountCollageMetadataRepository, AccountCollageMetadataRepository>();
        return services;
    }
}