namespace Restuarent_Backend.Dtos
{
    public class UpdateReservationsDto
    {
        public bool? IsAvailable { get; set; }
        public DateTime? ReservationStartDateTime { get; set; }
        public DateTime? ReservationEndDateTime { get; set; }
    }
}
