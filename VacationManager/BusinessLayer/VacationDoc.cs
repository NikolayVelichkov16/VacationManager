using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLayer
{
    public class VacationDoc
    {
        private VacationDoc()
        {

        }
        [Key]
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public DateTime CurrentDate { get; set; }
        public Worker Sender { get; set; }
        public bool MedicineReasons { get; set; }
        public byte[] ImageOfDoc { get; set; }


        public VacationDoc(int id, DateTime fromDate, DateTime toDate, DateTime currentDate, Worker sender, bool medicineReasons)
        {
            Id = id;
            FromDate = fromDate;
            ToDate = toDate;
            CurrentDate = DateTime.Now;
            Sender = sender;
            MedicineReasons = medicineReasons;
        }
    }
}