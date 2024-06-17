using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using web.models;
using webapi.models.kitchen;
using webapi.models.service;

namespace webapi.datacontext
{
    public class DataContext: DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Aromatics> aromatics => Set<Aromatics>();
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


            modelBuilder.Entity<AromaticServer>()
                .HasKey(e => e.id);    

        
            modelBuilder.Entity<CleanRestaurantServer>()
                .HasKey(e => e.id);    

            modelBuilder.Entity<FinalPrepServer>()
                .HasKey(e => e.id);    


            modelBuilder.Entity<PrepSaucesServer>()
                .HasKey(e => e.id);    

            modelBuilder.Entity<SaladPrepServer>()
                .HasKey(e => e.id);    
     
            modelBuilder.Entity<MainList>()
                .HasOne(e => e.aromatics)
                .WithOne(e => e.mainList)
                .HasForeignKey<Aromatics>(e => e.mainListId)
                .IsRequired();        


            modelBuilder.Entity<MainList>()
                .HasOne(e => e.arrivalBasics)
                .WithOne(e => e.mainList)
                .HasForeignKey<ArrivalBasics>(e => e.mainListId)
                .IsRequired();        
                
            
            modelBuilder.Entity<MainList>()
                .HasOne(e => e.brothPrep)
                .WithOne(e => e.mainList)
                .HasForeignKey<BrothPrep>(e => e.mainListId)
                .IsRequired();        


            modelBuilder.Entity<MainList>()
                .HasOne(e => e.finalPrep)
                .WithOne(e => e.mainList)
                .HasForeignKey<FinalPrep>(e => e.mainListId)
                .IsRequired();        

             modelBuilder.Entity<MainList>()
                .HasOne(e => e.prepProteins)
                .WithOne(e => e.mainList)
                .HasForeignKey<PrepProteins>(e => e.mainListId)
                .IsRequired();        

            modelBuilder.Entity<MainList>()
                .HasOne(e => e.prepSauces)
                .WithOne(e => e.mainList)
                .HasForeignKey<PrepSauces>(e => e.mainListId)
                .IsRequired();        

            
            modelBuilder.Entity<MainList>()
                .HasOne(e => e.saladPrep)
                .WithOne(e => e.mainList)
                .HasForeignKey<SaladPrep>(e => e.mainListId)
                .IsRequired();        


            modelBuilder.Entity<MainList>()
                .HasOne(e => e.stirFryVeg)
                .WithOne(e => e.mainList)
                .HasForeignKey<StirFryVeg>(e => e.mainListId)
                .IsRequired();        
                
            modelBuilder.Entity<MainList>()
                .HasOne(e => e.toppingsPrep)
                .WithOne(e => e.mainList)
                .HasForeignKey<ToppingsPrep>(e => e.mainListId)
                .IsRequired();        


            modelBuilder.Entity<MainList>()
                .HasOne(e => e.aromaticServer)
                .WithOne(e => e.mainList)
                .HasForeignKey<AromaticServer>(e => e.mainListId)
                .IsRequired();        
                
            
            modelBuilder.Entity<MainList>()
                .HasOne(e => e.cleanRestaurantServer)
                .WithOne(e => e.mainList)
                .HasForeignKey<CleanRestaurantServer>(e => e.mainListId)
                .IsRequired();        


            modelBuilder.Entity<MainList>()
                .HasOne(e => e.finalPrepServer)
                .WithOne(e => e.mainList)
                .HasForeignKey<FinalPrepServer>(e => e.mainListId)
                .IsRequired();        

            modelBuilder.Entity<MainList>()
                .HasOne(e => e.prepSaucesServer)
                .WithOne(e => e.mainList)
                .HasForeignKey<PrepSaucesServer>(e => e.mainListId)
                .IsRequired();        

            modelBuilder.Entity<MainList>()
                .HasOne(e => e.saladPrepServer)
                .WithOne(e => e.mainList)
                .HasForeignKey<SaladPrepServer>(e => e.mainListId)
                .IsRequired();        
    
        }
    }
}
