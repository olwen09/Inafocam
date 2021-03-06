﻿using Inafocam.core.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inafocam.Web.Areas.SeguimientoDeUniversidades.Models
{
    public class ScholarshipProgramTracingCourseFileModel
    {
        public long CourseFileId { get; set; }
        public long? TracingId { get; set; }
        public long? FileTypeId { get; set; }
        public long? FileId { get; set; }
        public long? ScholarshipProgramTracingCourseId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }
        public ScholarshipProgramTracingCourse ScholarshipProgramTracingCourse { get; set; }
        public virtual File File { get; set; }
        public virtual ScholarshipProgramTracingCourseFileType FileType { get; set; }
        public virtual Status Status { get; set; }
        public virtual ScholarshipProgramTracing Tracing { get; set; }
    }
}
