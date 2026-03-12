magdonal:
	cd src/Magdonal && dotnet build && dotnet publish
	clear
	src/Magdonal/bin/Debug/net9.0/Magdonal

magdonal2:
	dotnet run --project src/Magdonal