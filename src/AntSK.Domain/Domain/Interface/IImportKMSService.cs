﻿using AntSK.Domain.Model;

namespace AntSK.Domain.Domain.Interface
{
    public interface IImportKMSService
    {
        void ImportKMSTask(ImportKMSTaskReq req);
    }
}
