using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HealthCare.Appointments.Api.Constants;
using HealthCare.Appointments.Api.Dtos;
using HealthCare.Appointments.Api.Models;
using HealthCare.Appointments.Api.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HealthCare.Appointments.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentsController : ControllerBase
    {
        private readonly AppointmentsDbContext _context;
        private readonly IPatientsApiRepository _patientsApiRepository;
        private readonly ApiEndpoints _apiEndpoints;
        private readonly IMapper _mapper;

        public AppointmentsController(AppointmentsDbContext context, IPatientsApiRepository patientsApiRepository, ApiEndpoints apiEndpoints, IMapper mapper)
        {
            _context = context;
            _patientsApiRepository = patientsApiRepository;
            _apiEndpoints = apiEndpoints;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<Appointment>> GetAppointments()
        {
            var appointments = await _context.Appointments.ToListAsync();
            return Ok(appointments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppointmentDetailsDto>> GetAppointment(Guid id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }

            //other service call
            var patient = await _patientsApiRepository.GetPatient(appointment.PatientId);
            var appointmentDto = _mapper.Map<AppointmentDetailsDto>(appointment);
            appointmentDto.Patient = _mapper.Map<PatientDto>(patient);

            return Ok(appointmentDto);
        }

        [HttpPost]
        public async Task<ActionResult<Appointment>> PostAppointment(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppointment", new { id = appointment.Id }, appointment);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutAppointment(Guid id, Appointment appointment)
        {
            if (id != appointment.Id)
            {
                return BadRequest();
            }

            _context.Entry(appointment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppointmentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAppointment(Guid id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }

            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private bool AppointmentExists(Guid id)
        {
            return _context.Appointments.Any(e => e.Id == id);
        }
    }
}