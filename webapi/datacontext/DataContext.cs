
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using webapi.models;
using webapi.models.kitchen;
using webapi.models.service;

namespace webapi.datacontext
{
    public class DataContext: DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Aromatics> aromatics => Set<Aromatics>();
        public DbSet<ArrivalBasics> arrivalBasics => Set<ArrivalBasics>();
        public DbSet<BrothPrep> brothPrep => Set<BrothPrep>();

        public DbSet<FinalPrep> finalPrep => Set<FinalPrep>();
        public DbSet<PrepProteins> prepProteins => Set<PrepProteins>();
        public DbSet<PrepSauces> prepSauces => Set<PrepSauces>();
        public DbSet<SaladPrep> saladPrep => Set<SaladPrep>();
        public DbSet<StirFryVeg> stirFryVeg => Set<StirFryVeg>();
        public DbSet<ToppingsPrep> toppingsPrep => Set<ToppingsPrep>();
        public DbSet<AromaticsServer> aromaticsServer => Set<AromaticsServer>();
        public DbSet<CleanRestaurantServer> cleanRestaurantServer => Set<CleanRestaurantServer>();
        public DbSet<FinalPrepServer> finalPrepServer => Set<FinalPrepServer>();
        public DbSet<PrepSaucesServer> prepSaucesServer => Set<PrepSaucesServer>();
        public DbSet<SaladPrepServer> saladPrepServer => Set<SaladPrepServer>();
        public DbSet<CashierChecklist> cashierChecklist => Set<CashierChecklist>();
        public DbSet<StockOpeningCheckList> stockOpeningCheckList => Set<StockOpeningCheckList>();
        public DbSet<Signature> signature => Set<Signature>();

        public DbSet<MainList> mainList => Set<MainList>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<MainList>()
                .HasKey(e => e.id);

            modelBuilder.Entity<Aromatics>()
                .HasKey(e => e.id);    


            modelBuilder.Entity<ArrivalBasics>()
                .HasKey(e => e.id);    

        
            modelBuilder.Entity<BrothPrep>()
                .HasKey(e => e.id);    
            modelBuilder.Entity<FinalPrep>()
                .HasKey(e => e.id);    


            modelBuilder.Entity<PrepProteins>()
                .HasKey(e => e.id);    

            modelBuilder.Entity<PrepSauces>()
                .HasKey(e => e.id);    

        
            modelBuilder.Entity<SaladPrep>()
                .HasKey(e => e.id);    
            

            modelBuilder.Entity<StirFryVeg>()
                .HasKey(e => e.id);

            modelBuilder.Entity<ToppingsPrep>()
                .HasKey(e => e.id);    


            modelBuilder.Entity<AromaticsServer>()
                .HasKey(e => e.id);    

        
            modelBuilder.Entity<CleanRestaurantServer>()
                .HasKey(e => e.id);    

            modelBuilder.Entity<FinalPrepServer>()
                .HasKey(e => e.id);    


            modelBuilder.Entity<PrepSaucesServer>()
                .HasKey(e => e.id);    

            modelBuilder.Entity<SaladPrepServer>()
                .HasKey(e => e.id);    


            modelBuilder.Entity<CashierChecklist>()
                .HasKey(e => e.id);    

            modelBuilder.Entity<StockOpeningCheckList>()
                .HasKey(e => e.id);    
     
            modelBuilder.Entity<Signature>()
                .HasKey(e => e.id);   

            modelBuilder.Entity<MainList>()
                .HasOne(e => e.aromatics)
                .WithOne()
                .HasForeignKey<Aromatics>(e => e.mainListId)
                .IsRequired();        


            modelBuilder.Entity<MainList>()
                .HasOne(e => e.arrivalBasics)
                .WithOne()
                .HasForeignKey<ArrivalBasics>(e => e.mainListId)
                .IsRequired();        
                
            
            modelBuilder.Entity<MainList>()
                .HasOne(e => e.brothPrep)
                .WithOne()
                .HasForeignKey<BrothPrep>(e => e.mainListId)
                .IsRequired();        


            modelBuilder.Entity<MainList>()
                .HasOne(e => e.finalPrep)
                .WithOne()
                .HasForeignKey<FinalPrep>(e => e.mainListId)
                .IsRequired();        

             modelBuilder.Entity<MainList>()
                .HasOne(e => e.prepProteins)
                .WithOne()
                .HasForeignKey<PrepProteins>(e => e.mainListId)
                .IsRequired();        

            modelBuilder.Entity<MainList>()
                .HasOne(e => e.prepSauces)
                .WithOne()
                .HasForeignKey<PrepSauces>(e => e.mainListId)
                .IsRequired();        

            
            modelBuilder.Entity<MainList>()
                .HasOne(e => e.saladPrep)
                .WithOne()
                .HasForeignKey<SaladPrep>(e => e.mainListId)
                .IsRequired();        


            modelBuilder.Entity<MainList>()
                .HasOne(e => e.stirFryVeg)
                .WithOne()
                .HasForeignKey<StirFryVeg>(e => e.mainListId)
                .IsRequired();        
                
            modelBuilder.Entity<MainList>()
                .HasOne(e => e.toppingsPrep)
                .WithOne()
                .HasForeignKey<ToppingsPrep>(e => e.mainListId)
                .IsRequired();        


            modelBuilder.Entity<MainList>()
                .HasOne(e => e.aromaticsServer)
                .WithOne()
                .HasForeignKey<AromaticsServer>(e => e.mainListId)
                .IsRequired();        
                
            
            modelBuilder.Entity<MainList>()
                .HasOne(e => e.cleanRestaurantServer)
                .WithOne()
                .HasForeignKey<CleanRestaurantServer>(e => e.mainListId)
                .IsRequired();        


            modelBuilder.Entity<MainList>()
                .HasOne(e => e.finalPrepServer)
                .WithOne()
                .HasForeignKey<FinalPrepServer>(e => e.mainListId)
                .IsRequired();        

            modelBuilder.Entity<MainList>()
                .HasOne(e => e.prepSaucesServer)
                .WithOne()
                .HasForeignKey<PrepSaucesServer>(e => e.mainListId)
                .IsRequired();        

            modelBuilder.Entity<MainList>()
                .HasOne(e => e.saladPrepServer)
                .WithOne()
                .HasForeignKey<SaladPrepServer>(e => e.mainListId)
                .IsRequired();        

            modelBuilder.Entity<MainList>()
                .HasOne(e => e.cashierChecklist)
                .WithOne()
                .HasForeignKey<CashierChecklist>(e => e.mainListId)
                .IsRequired();        

            modelBuilder.Entity<MainList>()
                .HasOne(e => e.stockOpeningCheckList)
                .WithOne()
                .HasForeignKey<StockOpeningCheckList>(e => e.mainListId)
                .IsRequired();        

            modelBuilder.Entity<MainList>()
                .HasOne(e => e.signature)
                .WithOne()
                .HasForeignKey<Signature>(e => e.mainListId)
                .IsRequired();        


    
        }
    }
}
