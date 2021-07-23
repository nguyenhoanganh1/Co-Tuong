using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Entities
{
    [Table("ChessPosition")]
    public class ChessPosition
    {
        [Key]
        public int Id { get; set; }
        public string ChessId { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }
        public bool Visible { get; set; }
        public Guid RoomId { get; set; }


    }
}
