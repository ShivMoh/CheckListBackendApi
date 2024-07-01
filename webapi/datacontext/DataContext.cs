
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using webapi.models;
using webapi.models.files;
using webapi.models.form;
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
  
        public DbSet<KitchenCheckList> kitchenCheckList => Set<KitchenCheckList>();
        public DbSet<ServiceCheckList> serviceCheckList => Set<ServiceCheckList>();
        public DbSet<CashierChecklist> cashierChecklist => Set<CashierChecklist>();
        public DbSet<StockOpeningCheckList> stockOpeningCheckList => Set<StockOpeningCheckList>();

        public DbSet<Signature> signature => Set<Signature>();
        public DbSet<Comment> comment => Set<Comment>();

        public DbSet<FileType> fileType => Set<FileType>();
        private void setUpServiceCheckList(ModelBuilder modelBuilder) {

            modelBuilder.Entity<ServiceCheckList>()
                .HasOne(e => e.aromaticsServer)
                .WithOne()
                .HasForeignKey<AromaticsServer>(e => e.listId)
                .IsRequired();        
                
            
            modelBuilder.Entity<ServiceCheckList>()
                .HasOne(e => e.cleanRestaurantServer)
                .WithOne()
                .HasForeignKey<CleanRestaurantServer>(e => e.listId)
                .IsRequired();        


            modelBuilder.Entity<ServiceCheckList>()
                .HasOne(e => e.finalPrepServer)
                .WithOne()
                .HasForeignKey<FinalPrepServer>(e => e.listId)
                .IsRequired();        

            modelBuilder.Entity<ServiceCheckList>()
                .HasOne(e => e.prepSaucesServer)
                .WithOne()
                .HasForeignKey<PrepSaucesServer>(e => e.listId)
                .IsRequired();        

            modelBuilder.Entity<ServiceCheckList>()
                .HasOne(e => e.saladPrepServer)
                .WithOne()
                .HasForeignKey<SaladPrepServer>(e => e.listId)
                .IsRequired();        

            modelBuilder.Entity<ServiceCheckList>()
                .HasOne(e => e.signature)
                .WithOne()
                .HasForeignKey<ServiceCheckList>(e => e.signatureId)
                .IsRequired(false);        

            modelBuilder.Entity<ServiceCheckList>()
                .HasOne(e => e.comment)
                .WithOne()
                .HasForeignKey<ServiceCheckList>(e => e.commentId)
                .IsRequired(false);        

        }
        private void setUpKitchenCheckList(ModelBuilder modelBuilder) {
             
            modelBuilder.Entity<KitchenCheckList>()
                .HasOne(e => e.aromatics)
                .WithOne()
                .HasForeignKey<Aromatics>(e => e.listId)
                .IsRequired();        


            modelBuilder.Entity<KitchenCheckList>()
                .HasOne(e => e.arrivalBasics)
                .WithOne()
                .HasForeignKey<ArrivalBasics>(e => e.listId)
                .IsRequired();        
                
            
            modelBuilder.Entity<KitchenCheckList>()
                .HasOne(e => e.brothPrep)
                .WithOne()
                .HasForeignKey<BrothPrep>(e => e.listId)
                .IsRequired();        


            modelBuilder.Entity<KitchenCheckList>()
                .HasOne(e => e.finalPrep)
                .WithOne()
                .HasForeignKey<FinalPrep>(e => e.listId)
                .IsRequired();        

             modelBuilder.Entity<KitchenCheckList>()
                .HasOne(e => e.prepProteins)
                .WithOne()
                .HasForeignKey<PrepProteins>(e => e.listId)
                .IsRequired();        

            modelBuilder.Entity<KitchenCheckList>()
                .HasOne(e => e.prepSauces)
                .WithOne()
                .HasForeignKey<PrepSauces>(e => e.listId)
                .IsRequired();        

            
            modelBuilder.Entity<KitchenCheckList>()
                .HasOne(e => e.saladPrep)
                .WithOne()
                .HasForeignKey<SaladPrep>(e => e.listId)
                .IsRequired();        


            modelBuilder.Entity<KitchenCheckList>()
                .HasOne(e => e.stirFryVeg)
                .WithOne()
                .HasForeignKey<StirFryVeg>(e => e.listId)
                .IsRequired();        
                
            modelBuilder.Entity<KitchenCheckList>()
                .HasOne(e => e.toppingsPrep)
                .WithOne()
                .HasForeignKey<ToppingsPrep>(e => e.listId)
                .IsRequired();   

            modelBuilder.Entity<KitchenCheckList>()
                .HasOne(e => e.signature)
                .WithOne()
                .HasForeignKey<KitchenCheckList>(e => e.signatureId)
                .IsRequired(false);        

            modelBuilder.Entity<KitchenCheckList>()
                .HasOne(e => e.comment)
                .WithOne()
                .HasForeignKey<KitchenCheckList>(e => e.commentId)
                .IsRequired(false);        
   

        }

        private void setUpCashierCheckList(ModelBuilder modelBuilder) {
            modelBuilder.Entity<CashierChecklist>()
                .HasOne(e => e.signature)
                .WithOne()
                .HasForeignKey<CashierChecklist>(e => e.signatureId)
                .IsRequired(false);        

            modelBuilder.Entity<CashierChecklist>()
                .HasOne(e => e.comment)
                .WithOne()
                .HasForeignKey<CashierChecklist>(e => e.commentId)
                .IsRequired(false);        
        }

        private void setUpStockOpeningCheckList(ModelBuilder modelBuilder) {
            modelBuilder.Entity<StockOpeningCheckList>()
                .HasOne(e => e.signature)
                .WithOne()
                .HasForeignKey<StockOpeningCheckList>(e => e.signatureId)
                .IsRequired(false);        

            modelBuilder.Entity<StockOpeningCheckList>()
                .HasOne(e => e.comment)
                .WithOne()
                .HasForeignKey<StockOpeningCheckList>(e => e.commentId)
                .IsRequired(false);        
   
        }

        private void setUpPrimaryKeys(ModelBuilder modelBuilder) {
          
            modelBuilder.Entity<ServiceCheckList>()
                .Ignore(e => e.files)
                .HasKey(e => e.id);

            modelBuilder.Entity<KitchenCheckList>()
                .Ignore(e => e.files)
                .HasKey(e => e.id);

            modelBuilder.Entity<StockOpeningCheckList>()
                .Ignore(e => e.files)
                .HasKey(e => e.id);

            modelBuilder.Entity<CashierChecklist>()
                .Ignore(e => e.files)
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

     
            modelBuilder.Entity<Signature>()
                .HasKey(e => e.id);   


            modelBuilder.Entity<Comment>()
                .HasKey(e => e.id);   

            modelBuilder.Entity<FileType>()
                .HasKey(e => e.id);
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            this.setUpPrimaryKeys(modelBuilder);
            this.setUpServiceCheckList(modelBuilder);
            this.setUpKitchenCheckList(modelBuilder);
            this.setUpCashierCheckList(modelBuilder);
            this.setUpStockOpeningCheckList(modelBuilder);
          
        }
    }
}
