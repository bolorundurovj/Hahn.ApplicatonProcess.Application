#Project Variables

PROJECT_NAME ?= Hahn.ApplicatonProcess.Application

.PHONY: migrations db hello

migrations:
		cd ./Hahn.ApplicatonProcess.May2020.Data && dotnet ef --startup-project ../Hahn.ApplicatonProcess.May2020.Web/ migrations add $(mname) && cd ..

db:
		cd ./Hahn.ApplicatonProcess.May2020.Data && dotnet ef --startup-project ../Hahn.ApplicatonProcess.May2020.Web/ database update && cd ..

hello:
		echo 'hello!'