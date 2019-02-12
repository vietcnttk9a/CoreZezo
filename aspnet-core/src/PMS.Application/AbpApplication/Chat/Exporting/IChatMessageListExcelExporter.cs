using System.Collections.Generic;
using PMS.Chat.Dto;
using PMS.Dto;

namespace PMS.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(List<ChatMessageExportDto> messages);
    }
}
