<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
﻿using System.ComponentModel.DataAnnotations.Schema;
=======
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> Stashed changes
=======
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> Stashed changes
=======
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> Stashed changes

namespace API_Vinted.Models.EntityFramework
{
    [Table("photo")]
    public class Photo
    {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        [InverseProperty(nameof(Client.Photo))]
        public List<Client> Clients { get; set; } = null!;
=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        [Key]
        [Column("idphoto")]
        public int IDPhoto { get; set; }

        [Required]
        [Column("urlphoto")]
        public string URLPhoto { get; set; } = null!;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }
}
