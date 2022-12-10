using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ConferenceRegistration.Data;
public class ConferenceRegistrationDbContext : DbContext
{
	public ConferenceRegistrationDbContext(
	DbContextOptions<ConferenceRegistrationDbContext> options)
	: base(options)
	{
	}
	public DbSet<Participant> Participants => Set<Participant>();
}
