SET version=74.0.3729.6
call powershell -command "wget -O ./driver/chromedriver.zip https://chromedriver.storage.googleapis.com/%version%/chromedriver_win32.zip"
call powershell -command "Expand-Archive ./driver/chromedriver.zip -DestinationPath ./driver"
del driver\chromedriver.zip