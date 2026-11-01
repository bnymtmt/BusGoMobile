using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusGoMobile.Models
{
    public enum SeatStatus
    {
        Empty,      // boş
        Male,       // erkek dolu
        Female,     // kadın dolu
        Selected    // kullanıcı seçti
    }

    public class Seat
    {
        public int Number { get; set; }
        public SeatStatus Status { get; set; }

        // Boş koltuk tıklanabilir; dolu olanlar değil
        public bool IsSelectable => Status == SeatStatus.Empty || Status == SeatStatus.Selected;
    }


}
