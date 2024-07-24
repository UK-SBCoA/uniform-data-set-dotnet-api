using Microsoft.AspNetCore.Mvc;
using UDS.Net.API.Client;
using UDS.Net.API.Data;
using UDS.Net.Dto;

namespace UDS.Net.API.Controllers
{
    public class PacketSubmissionsController : Controller, IPacketSubmissionClient
    {
        private readonly ApiDbContext _context;

        public PacketSubmissionsController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet("Count", Name = "PacketSubmissionsCount")]
        public async Task<int> Count()
        {
            throw new NotImplementedException();
        }

        [HttpGet("Count/ByVisit/{visitId}", Name = "PacketSubmissionsCountByVisit")]
        public async Task<int> PacketSubmissionsCountByVisit(int visitId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("Count/ByStatus/{packetStatus}", Name = "PacketSubmissionsCountByStatus")]
        public async Task<int> PacketSubmissionsCountByStatus(string packetStatus)
        {
            throw new NotImplementedException();
        }




        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IEnumerable<PacketSubmissionDto>> Get(int pageSize = 10, int pageIndex = 1)
        {
            throw new NotImplementedException();
        }

        [HttpGet("ByVisit/{visitId}", Name = "GetPacketSubmissionByVisit")]
        public async Task<List<PacketSubmissionDto>> GetPacketSubmissionsByVisit(int visitId, int pageSize = 10, int pageIndex = 1)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<PacketSubmissionDto> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task Post(PacketSubmissionDto dto)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task Put(int id, PacketSubmissionDto dto)
        {
            throw new NotImplementedException();
        }

        [HttpGet("Errors/ByAssigned/{assignedTo}", Name = "GetPacketSubmissionErrorsByAssigned")]
        public async Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrorsByAssignee(string assignedTo)
        {
            throw new NotImplementedException();
        }

        [HttpGet("Errors/ByVisit/{visitId}", Name = "GetPacketSubmissionErrorsByVisit")]
        public async Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrorsByVisit(int visitId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("Errors/ByStatus/{packetStatus}", Name = "GetPacketSubmissionErrorsByStatus")]
        public async Task<List<PacketSubmissionDto>> GetPacketSubmissionsByStatus(string packetStatus)
        {
            throw new NotImplementedException();
        }


        public async Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrors(bool includeResolved = false)
        {
            throw new NotImplementedException();
        }

        public async Task PostPacketSubmissionError(int packetSubmissionId, PacketSubmissionErrorDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task PutPacketSubmissionError(int packetSubmissionId, PacketSubmissionErrorDto dto)
        {
            throw new NotImplementedException();
        }


        public Task<List<PacketSubmissionDto>> GetPacketSubmissionsByStatus(string packetStatus, int pageSize = 10, int pageIndex = 1)
        {
            throw new NotImplementedException();
        }

        public Task<int> PacketSubmissionErrorsCount(bool includeResolved = false)
        {
            throw new NotImplementedException();
        }

        public Task<int> PacketSubmissionsErrorsCountByVisit(int visitId)
        {
            throw new NotImplementedException();
        }

        public Task<int> PacketSubmissionsErrorsCountyByAssignee(string assignedTo)
        {
            throw new NotImplementedException();
        }

        public Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrors(bool includeResolved = false, int pageSize = 10, int pageIndex = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrorsByVisit(int visitId, int pageSize = 10, int pageIndex = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrorsByAssignee(string assignedTo, int pageSize = 10, int pageIndex = 1)
        {
            throw new NotImplementedException();
        }
    }
}

