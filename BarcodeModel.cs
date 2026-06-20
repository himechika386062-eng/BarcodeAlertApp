using Postgrest.Attributes;
using Postgrest.Models;

namespace BarcodeAlertApp
{
    // Supabaseの「barcodes」テーブルと紐付け
    [Table("barcodes")]
    public class BarcodeModel : BaseModel
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }

        // バーコードの数値を保存する列
        [Column("code")]
        public string Code { get; set; }
    }
}