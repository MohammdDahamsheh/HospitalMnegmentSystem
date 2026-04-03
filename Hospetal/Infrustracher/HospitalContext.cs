using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrustracher
{
    public class HospitalContext: DbContext
    {

        public DbSet<Patients> Patients { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Admissions> Admissions { get; set; }
        public DbSet<MedicalRecords> MedicalRecords { get; set; }
        public DbSet<Prescriptions> Prescriptions { get; set; }
        public DbSet<Bills> Bills { get; set; }
        public DbSet<BillsItems> BillsItems { get; set; }
        public DbSet <PrescriptionItems> PrescriptionItems { get; set; }
        public DbSet <Rooms> Rooms { get; set; }
        public DbSet <Beds > Beds { get; set; }
        public DbSet <Suppliers> Suppliers { get; set; }
        public DbSet <Medicines> Medicines { get; set; }
        public DbSet <LabTests> LabTests { get; set; }




        public HospitalContext(DbContextOptions<HospitalContext> options)
           : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NRLBL9O\\SQLEXPRESS01;database=HMS;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctors>()
                .HasOne(d => d.user)
                .WithOne()
                .HasForeignKey<Doctors>(d => d.userId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Appointments>()
                .HasOne(a => a.patient)
                .WithMany(p => p.appointments)
                .HasForeignKey(a => a.patientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Appointments>()
                .HasOne(a => a.doctor)
                .WithMany(d => d.appointments)
                .HasForeignKey(a => a.doctorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Appointments>()
                .HasOne(a => a.department)
                .WithMany(d => d.appointments)
                .HasForeignKey(a => a.departmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Admissions>()
                .HasOne(a => a.patient)
                .WithMany(p => p.admissions)
                .HasForeignKey(a => a.patientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Admissions>()
                .HasOne(a => a.doctor)
                .WithMany(d => d.admissions)
                .HasForeignKey(a => a.doctorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Admissions>()
                .HasOne(a => a.room)
                .WithMany(r => r.admissions)
                .HasForeignKey(a => a.roomId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Admissions>()
                .HasOne(a => a.bed)
                .WithMany(b => b.admissions)
                .HasForeignKey(a => a.bedId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Beds>()
                .HasOne(b => b.room)
                .WithMany(r => r.beds)
                .HasForeignKey(b => b.roomId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Bills>()
                .HasOne(b => b.patient)
                .WithMany(p => p.bills)
                .HasForeignKey(b => b.patientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BillsItems>()
                .HasOne(bi => bi.bill)
                .WithMany(b => b.billItems)
                .HasForeignKey(bi => bi.billId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<LabTests>()
                .HasOne(lt => lt.patient)
                .WithMany(p => p.labTests)
                .HasForeignKey(lt => lt.patientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LabTests>()
                .HasOne(lt => lt.doctor)
                .WithMany()
                .HasForeignKey(lt => lt.doctorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MedicalRecords>()
                .HasOne(mr => mr.patient)
                .WithMany(p => p.medicalRecords)
                .HasForeignKey(mr => mr.patientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MedicalRecords>()
                .HasOne(mr => mr.doctor)
                .WithMany()
                .HasForeignKey(mr => mr.doctorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Medicines>()
                .HasOne(m => m.supplier)
                .WithMany(s => s.medicines)
                .HasForeignKey(m => m.supplierId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Prescriptions>()
                .HasOne(p => p.medicalRecord)
                .WithMany(mr => mr.prescriptions)
                .HasForeignKey(p => p.medicalRecordId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PrescriptionItems>()
                .HasOne(pi => pi.prescription)
                .WithMany(p => p.prescriptionItems)
                .HasForeignKey(pi => pi.prescriptionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PrescriptionItems>()
                .HasOne(pi => pi.medicine)
                .WithMany()
                .HasForeignKey(pi => pi.medicineId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
