using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace InfertilityTreatmentSystem.Models;

public partial class Test6Context : DbContext
{
    public Test6Context()
    {
    }

    public Test6Context(DbContextOptions<Test6Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Examination> Examinations { get; set; }

    public virtual DbSet<Feedback> Feedbacks { get; set; }

    public virtual DbSet<InfoDoctor> InfoDoctors { get; set; }

    public virtual DbSet<MedicalRecord> MedicalRecords { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Result> Results { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<TreatmentProcess> TreatmentProcesses { get; set; }

    public virtual DbSet<TreatmentService> TreatmentServices { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("DBDefault");
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>(entity =>
        {
            entity.HasKey(e => e.IdBlog).HasName("PK__Blog__F1F67AB8ACC8AEA6");

            entity.ToTable("Blog");

            entity.Property(e => e.IdBlog).HasColumnName("ID_Blog");
            entity.Property(e => e.Author).HasMaxLength(100);
            entity.Property(e => e.Top1).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__Booking__35ABFDE0DD65E7DB");

            entity.ToTable("Booking");

            entity.Property(e => e.BookingId).HasColumnName("Booking_ID");
            entity.Property(e => e.CreateAt).HasColumnName("create_at");
            entity.Property(e => e.NumberPhone)
                .HasMaxLength(20)
                .HasColumnName("Number_Phone");
            entity.Property(e => e.StatusBooking)
                .HasMaxLength(50)
                .HasColumnName("status_booking");
            entity.Property(e => e.TreatmentServiceId).HasColumnName("TreatmentService_ID");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.TreatmentService).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.TreatmentServiceId)
                .HasConstraintName("FK__Booking__Treatme__46E78A0C");

            entity.HasOne(d => d.User).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Booking__User_ID__47DBAE45");
        });

        modelBuilder.Entity<Examination>(entity =>
        {
            entity.HasKey(e => e.ExaminationId).HasName("PK__Examinat__D05D757C2F6E9334");

            entity.ToTable("Examination");

            entity.Property(e => e.ExaminationId).HasColumnName("Examination_ID");
            entity.Property(e => e.BookingId).HasColumnName("Booking_ID");
            entity.Property(e => e.DateMeet).HasColumnName("date_meet");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.Booking).WithMany(p => p.Examinations)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("FK__Examinati__Booki__4AB81AF0");

            entity.HasOne(d => d.User).WithMany(p => p.Examinations)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Examinati__User___4BAC3F29");
        });

        modelBuilder.Entity<Feedback>(entity =>
        {
            entity.HasKey(e => e.FeedbackId).HasName("PK__Feedback__CD3992F8D5F1661D");

            entity.ToTable("Feedback");

            entity.Property(e => e.FeedbackId).HasColumnName("Feedback_ID");
            entity.Property(e => e.ContentFeedback)
                .HasMaxLength(500)
                .HasColumnName("content_feedback");
            entity.Property(e => e.CreateAt)
                .HasColumnType("datetime")
                .HasColumnName("Create_at");
            entity.Property(e => e.NumberPhone)
                .HasMaxLength(20)
                .HasColumnName("Number_Phone");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.TargetType)
                .HasMaxLength(50)
                .HasColumnName("Target_type");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.User).WithMany(p => p.Feedbacks)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Feedback__User_I__571DF1D5");
        });

        modelBuilder.Entity<InfoDoctor>(entity =>
        {
            entity.HasKey(e => e.InfoId).HasName("PK__Info_doc__072F05074DD43D0A");

            entity.ToTable("Info_doctor");

            entity.HasIndex(e => e.UserId, "UQ__Info_doc__206D919122EE8187").IsUnique();

            entity.Property(e => e.InfoId).HasColumnName("Info_ID");
            entity.Property(e => e.Certificate)
                .HasMaxLength(255)
                .HasColumnName("certificate");
            entity.Property(e => e.Degree)
                .HasMaxLength(100)
                .HasColumnName("degree");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.ExperianYear).HasColumnName("experian_year");
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .HasColumnName("full_name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("phone_number");
            entity.Property(e => e.Speciality)
                .HasMaxLength(100)
                .HasColumnName("speciality");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.User).WithOne(p => p.InfoDoctor)
                .HasForeignKey<InfoDoctor>(d => d.UserId)
                .HasConstraintName("FK__Info_doct__User___3D5E1FD2");
        });

        modelBuilder.Entity<MedicalRecord>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK__Medical___603A0C602797A02C");

            entity.ToTable("Medical_Record");

            entity.Property(e => e.RecordId).HasColumnName("Record_ID");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Created_at");
            entity.Property(e => e.NumberPhone)
                .HasMaxLength(20)
                .HasColumnName("Number_Phone");
            entity.Property(e => e.Summary).HasMaxLength(500);
            entity.Property(e => e.TreatmentProcessId).HasColumnName("TreatmentProcess_ID");

            entity.HasOne(d => d.TreatmentProcess).WithMany(p => p.MedicalRecords)
                .HasForeignKey(d => d.TreatmentProcessId)
                .HasConstraintName("FK__Medical_R__Treat__5441852A");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__Member__42A68F275B89D968");

            entity.ToTable("Member");

            entity.HasIndex(e => e.UserId, "UQ__Member__206D91917C72AC34").IsUnique();

            entity.Property(e => e.MemberId).HasColumnName("Member_ID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasColumnName("gender");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .HasColumnName("phone_number");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.User).WithOne(p => p.Member)
                .HasForeignKey<Member>(d => d.UserId)
                .HasConstraintName("FK__Member__User_ID__412EB0B6");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK__Notifica__8C1160B582F57907");

            entity.ToTable("Notification");

            entity.Property(e => e.NotificationId).HasColumnName("Notification_ID");
            entity.Property(e => e.ContentNoti)
                .HasMaxLength(500)
                .HasColumnName("content_noti");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Created_at");
            entity.Property(e => e.IsRead).HasColumnName("Is_read");
            entity.Property(e => e.NumberPhone)
                .HasMaxLength(20)
                .HasColumnName("Number_Phone");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.User).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Notificat__User___5BE2A6F2");
        });

        modelBuilder.Entity<Result>(entity =>
        {
            entity.HasKey(e => e.ResultId).HasName("PK__Result__5E08F543399E9BBC");

            entity.ToTable("Result");

            entity.Property(e => e.ResultId).HasColumnName("Result_ID");
            entity.Property(e => e.ExaminationId).HasColumnName("Examination_ID");
            entity.Property(e => e.ResultTest)
                .HasMaxLength(500)
                .HasColumnName("Result_test");
            entity.Property(e => e.TreatmentProcessId).HasColumnName("TreatmentProcess_ID");

            entity.HasOne(d => d.Examination).WithMany(p => p.Results)
                .HasForeignKey(d => d.ExaminationId)
                .HasConstraintName("FK__Result__Examinat__4E88ABD4");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__D80AB49BAFAE3FC3");

            entity.ToTable("Role");

            entity.Property(e => e.RoleId).HasColumnName("Role_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TreatmentProcess>(entity =>
        {
            entity.HasKey(e => e.TreatmentProcessId).HasName("PK__Treatmen__AB6EF780713767FD");

            entity.ToTable("TreatmentProcess");

            entity.Property(e => e.TreatmentProcessId).HasColumnName("TreatmentProcess_ID");
            entity.Property(e => e.DateTreatment).HasColumnName("date_treatment");
            entity.Property(e => e.Descriptions)
                .HasMaxLength(500)
                .HasColumnName("descriptions");
            entity.Property(e => e.MedicalRecordsId).HasColumnName("MedicalRecords_ID");
            entity.Property(e => e.PlanTreatment)
                .HasMaxLength(500)
                .HasColumnName("plan_treatment");
            entity.Property(e => e.ResultId).HasColumnName("Result_ID");

            entity.HasOne(d => d.Result).WithMany(p => p.TreatmentProcesses)
                .HasForeignKey(d => d.ResultId)
                .HasConstraintName("FK__Treatment__Resul__5165187F");
        });

        modelBuilder.Entity<TreatmentService>(entity =>
        {
            entity.HasKey(e => e.TreatmentServiceId).HasName("PK__Treatmen__7AD5BD1088C0A711");

            entity.ToTable("TreatmentService");

            entity.Property(e => e.TreatmentServiceId).HasColumnName("TreatmentService_ID");
            entity.Property(e => e.Descriptions)
                .HasMaxLength(500)
                .HasColumnName("descriptions");
            entity.Property(e => e.Durations)
                .HasMaxLength(50)
                .HasColumnName("durations");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("price");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.User).WithMany(p => p.TreatmentServices)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Treatment__User___440B1D61");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__206D9190F0538C71");

            entity.ToTable("User");

            entity.Property(e => e.UserId).HasColumnName("User_ID");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.RoleId).HasColumnName("Role_ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .HasColumnName("user_name");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__User__Role_ID__398D8EEE");

            entity.HasMany(d => d.IdBlogs).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "StaffBlog",
                    r => r.HasOne<Blog>().WithMany()
                        .HasForeignKey("IdBlog")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Staff_Blo__ID_Bl__5FB337D6"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Staff_Blo__User___5EBF139D"),
                    j =>
                    {
                        j.HasKey("UserId", "IdBlog").HasName("PK__Staff_Bl__BF72F63BD6E22378");
                        j.ToTable("Staff_Blog");
                        j.IndexerProperty<int>("UserId").HasColumnName("User_ID");
                        j.IndexerProperty<int>("IdBlog").HasColumnName("ID_Blog");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
