﻿using System.Threading.Tasks;

namespace ENode.Infrastructure
{
    /// <summary>Represents a storage to store the message handle records.
    /// </summary>
    public interface IMessageHandleRecordStore
    {
        /// <summary>Add a message handle record.
        /// </summary>
        /// <param name="record"></param>
        Task<AsyncTaskResult> AddRecordAsync(MessageHandleRecord record);
        /// <summary>Check whether the message handle record exist.
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="handlerTypeCode"></param>
        /// <returns></returns>
        Task<AsyncTaskResult<bool>> IsRecordExistAsync(string messageId, int handlerTypeCode);
    }
}
