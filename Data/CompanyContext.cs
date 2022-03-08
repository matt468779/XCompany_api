using Microsoft.EntityFrameworkCore;
using XCompany_api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
namespace XCompany_api.Data;

public class CompanyContext : DbContext{
    public CompanyContext (DbContextOptions<CompanyContext> options) : base(options){

    }

    
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Capability> Capabilities => Set<Capability>();
    public DbSet<Item> Items => Set<Item>();
    public DbSet<ItemQuantity> ItemQuantities => Set<ItemQuantity>();
    public DbSet<Office> Offices => Set<Office>();
    public DbSet<WeeklyPlan> WeeklyPlans => Set<WeeklyPlan>();
    public DbSet<MonthlyPlan> MonthlyPlans => Set<MonthlyPlan>();
    public DbSet<YearlyPlan> YearlyPlans => Set<YearlyPlan>();
    public DbSet<Sale> Sales => Set<Sale>();
    public DbSet<Unit> Units => Set<Unit>();
    public DbSet<LoginModel> LoginModels => Set<LoginModel>();
    public DbSet<RegisterModel> RegisterModels => Set<RegisterModel>();
    public DbSet<Response> Responses => Set<Response>();
    public DbSet<IdentityUser> IdentityUsers => Set<IdentityUser>();
    public DbSet<IdentityRole> IdentityRoles => Set<IdentityRole>();
    public DbSet<IdentityUserRole<string>> IdentityUserRoles => Set<IdentityUserRole<string>>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<IdentityUserRole<string>>()
            .HasKey(i => new {i.UserId, i.RoleId});
    }










}