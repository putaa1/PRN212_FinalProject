using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ThangNPHE151263_FinalProject.Models;

public partial class MilkTeaContext : DbContext
{
    public MilkTeaContext()
    {
    }

    public MilkTeaContext(DbContextOptions<MilkTeaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<BillDetail> BillDetails { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<GroupProduct> GroupProducts { get; set; }

    public virtual DbSet<GroupTable> GroupTables { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<LoginRole> LoginRoles { get; set; }

    public virtual DbSet<MenuItem> MenuItems { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server =(local); database = MilkTea;uid=sa;pwd=123;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbBill__3213E83F9B558EBB");

            entity.ToTable("Bill");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BillDate)
                .HasColumnType("datetime")
                .HasColumnName("billDate");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");
            entity.Property(e => e.IdTable).HasColumnName("idTable");
            entity.Property(e => e.IdUser).HasColumnName("idUser");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TotalMoney).HasColumnName("totalMoney");

            entity.HasOne(d => d.IdCustomerNavigation).WithMany(p => p.Bills)
                .HasForeignKey(d => d.IdCustomer)
                .HasConstraintName("FK__tbBill__idCustom__4F7CD00D");

            entity.HasOne(d => d.IdTableNavigation).WithMany(p => p.Bills)
                .HasForeignKey(d => d.IdTable)
                .HasConstraintName("FK__tbBill__idTable__4D94879B");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Bills)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK__tbBill__idUser__4E88ABD4");
        });

        modelBuilder.Entity<BillDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbBillDe__3213E83FD321E45F");

            entity.ToTable("BillDetail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.IdBill).HasColumnName("idBill");
            entity.Property(e => e.IdProduct).HasColumnName("idProduct");
            entity.Property(e => e.IntoMoney).HasColumnName("intoMoney");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.UnitPrice).HasColumnName("unitPrice");

            entity.HasOne(d => d.IdBillNavigation).WithMany(p => p.BillDetails)
                .HasForeignKey(d => d.IdBill)
                .HasConstraintName("FK__tbBillDet__idBil__52593CB8");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.BillDetails)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("FK__tbBillDet__idPro__534D60F1");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbCustom__3213E83F4B5E2FE6");

            entity.ToTable("Customer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .HasColumnName("address");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3213E83FB7264583");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .HasColumnName("address");
            entity.Property(e => e.DateWork).HasColumnName("dateWork");
            entity.Property(e => e.FullName)
                .HasMaxLength(250)
                .HasColumnName("fullName");
            entity.Property(e => e.IdCard)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("idCard");
            entity.Property(e => e.Img).HasColumnName("img");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("phoneNumber");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<GroupProduct>(entity =>
        {
            entity.HasKey(e => e.IdGr).HasName("PK__tbGroupP__9DB891D57F4F6C81");

            entity.ToTable("GroupProduct");

            entity.Property(e => e.IdGr).HasColumnName("idGr");
            entity.Property(e => e.DescriptionGr)
                .HasMaxLength(500)
                .HasColumnName("descriptionGr");
            entity.Property(e => e.NameGr)
                .HasMaxLength(500)
                .HasColumnName("nameGr");
        });

        modelBuilder.Entity<GroupTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbGroupT__3213E83F03C293F1");

            entity.ToTable("GroupTable");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Login__3213E83F7DA5C36B");

            entity.ToTable("Login");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdEmployee).HasColumnName("idEmployee");
            entity.Property(e => e.IsUse).HasColumnName("isUse");
            entity.Property(e => e.Password)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("userName");

            entity.HasOne(d => d.IdEmployeeNavigation).WithMany(p => p.Logins)
                .HasForeignKey(d => d.IdEmployee)
                .HasConstraintName("FK__Login__idEmploye__398D8EEE");
        });

        modelBuilder.Entity<LoginRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LoginRol__3213E83F8156CDD3");

            entity.ToTable("LoginRole");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdLogin).HasColumnName("idLogin");
            entity.Property(e => e.IdMenuItems).HasColumnName("idMenuItems");

            entity.HasOne(d => d.IdLoginNavigation).WithMany(p => p.LoginRoles)
                .HasForeignKey(d => d.IdLogin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LoginRole__idLog__3E52440B");

            entity.HasOne(d => d.IdMenuItemsNavigation).WithMany(p => p.LoginRoles)
                .HasForeignKey(d => d.IdMenuItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LoginRole__idMen__3F466844");
        });

        modelBuilder.Entity<MenuItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MenuItem__3213E83F645AF83E");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameMenu)
                .HasMaxLength(250)
                .HasColumnName("nameMenu");
            entity.Property(e => e.NameShow)
                .HasMaxLength(250)
                .HasColumnName("nameShow");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbProduc__3213E83F4B9D92C3");

            entity.ToTable("Product");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.IdGroupProduct).HasColumnName("idGroupProduct");
            entity.Property(e => e.Img)
                .IsUnicode(false)
                .HasColumnName("img");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasColumnName("unit");
            entity.Property(e => e.UnitPrice).HasColumnName("unitPrice");

            entity.HasOne(d => d.IdGroupProductNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdGroupProduct)
                .HasConstraintName("FK__tbProduct__idGro__45F365D3");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbStore__3213E83FC04025CE");

            entity.ToTable("Store");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressStore)
                .HasMaxLength(500)
                .HasColumnName("addressStore");
            entity.Property(e => e.NameStore)
                .HasMaxLength(500)
                .HasColumnName("nameStore");
            entity.Property(e => e.PhoneStore)
                .HasMaxLength(500)
                .HasColumnName("phoneStore");
            entity.Property(e => e.TaxCode)
                .HasMaxLength(250)
                .HasColumnName("taxCode");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbTable__3213E83FC5351180");

            entity.ToTable("Table");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.IdGroup).HasColumnName("idGroup");
            entity.Property(e => e.NameTb)
                .HasMaxLength(50)
                .HasColumnName("nameTb");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.Tables)
                .HasForeignKey(d => d.IdGroup)
                .HasConstraintName("FK__tbTable__idGroup__4AB81AF0");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
