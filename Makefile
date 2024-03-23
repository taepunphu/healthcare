run-appointment:
	dotnet run --project ./HealthCare.Appointments.Api/HealthCare.Appointments.Api.csproj
run-doctor:
	dotnet run --project ./HealthCare.Doctors.Api/HealthCare.Doctors.Api.csproj
run-document:
	dotnet run --project ./HealthCare.Documents.Api/HealthCare.Documents.Api.csproj
watch: 
	dotnet watch --project ./HealthCare.Appointments.Api/HealthCare.Appointments.Api.csproj

docker-db-up:
	docker compose -f ./docker-compose.db.yml up -d

docker-db-down:
	docker compose -f ./docker-compose.db.yml down

.PHONY: run, watch, docker-db-up, docker-db-down, run-appointment, run-doctor, run-document