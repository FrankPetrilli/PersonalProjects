MailPortScanner.dll: MailPortScanner.cs
	mcs -t:library MailPortScanner.cs
MailPortClient.exe: MailPortClient.cs MailPortScanner.dll
	mcs -r:MailPortScanner.dll MailPortClient.cs
MailServerTest.exe : MailServerTest.cs
	mcs MailServerTest.cs
