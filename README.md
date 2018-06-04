# GameClassification

Realizar download e instalar rabbitmq-server-3.7.5 ->
	https://dl.bintray.com/rabbitmq/all/rabbitmq-server/3.7.5/rabbitmq-server-3.7.5.exe

Instalar pacote no projeto no GameClassification.Application ->
	Install-Package EasyNetQ

Instalar pacote no projeto GameClassification.Infra.Data ->
	Install-Package EntityFramework -Version 6.1.3

Configurar connectionString e executar comando no projeto GameClassification.Infra.Data ->
	update-datebase -verbose -force
