﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rauthor.Models
{
    [Table("participant")]
    public class Participant
    {
        [Key]
        [Column("GUID")]
        public Guid Guid { get; set; }

        [NotMapped]
        [DisplayName("Рейтинг у пользователей")]
        public int UserScore => Votes.Where(v => v.VoteState == VoteState.Up).Count();

        [Column("competition_GUID")]
        public Guid CompetitionGuid { get; set; }

        [Column("user_GUID")]
        public Guid UserGuid { get; set; }

        [Column("status", TypeName = "enum('New','Approved','Rejected','Updated')")]
        [DisplayName("Состояние заявки")]
        public ParticipantStatus Status { get; set; }

        [NotMapped]
        public bool Approved => Status == ParticipantStatus.Approved;

        public virtual List<Poem> Poems { get; set; }

        [ForeignKey("CompetitionGuid")]
        public virtual Competition Competition { get; set; }

        [ForeignKey("UserGuid")]
        public virtual User User { get; set; }

        public List<VoteOfUser> Votes { get; set; }

        public Participant()
        {
            Guid = Guid.NewGuid();
        }
    }
    public enum ParticipantStatus
    {
        New,
        Approved,
        Rejected,
        Updated
    }
}
