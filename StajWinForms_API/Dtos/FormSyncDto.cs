using System.ComponentModel.DataAnnotations;

namespace StajWinForms_API.Dtos
{
    public record FormSyncDto(
        [Required, StringLength(100)] string FormAdi,
        [Required, StringLength(200)] string FormAciklamasi);
}