# EFCoreCodeFirstSeparetedProjects
.Net Core EF using code first approach in separeted projects (Class Library and Layers) and an API project to consume some data

To create Migration, open Package Manager Console, choose ConnectorIac.Dal Project and type the command add-migration name_of_migration

To update database mannualy, you can running in the Package Manager Console (choosing ConnectorIac.Dal Project) the command update-database
Or you can just running the default project ConnectorIac.Api that will running the migrations created. It's implemented on this project to execute migrations automatically.

- Other Migration commands:

  add-migration name_of_migration (to create migration)

  update-database or update-database name_of_migration (for update a specific migration)

  remove-migration (to remove last migration)

  script-migration (to generate the scripts SQL of migrations)

For more information about migration use for reference https://www.entityframeworktutorial.net/efcore/entity-framework-core-migration.aspx
