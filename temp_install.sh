docker run --name mysql -e MYSQL_ROOT_PASSWORD=admin -e MYSQL_DATABASE=openams -e MYSQL_USER=admin -e MSQL_PWD=admin -p 3306:3306 -d mysql:latest

docker container exec -it mysql bash

mysql -u root -p

CREATE USER 'admin'@'%' IDENTIFIED BY 'admin';
GRANT ALL PRIVILEGES ON *.* TO 'admin'@'%' WITH GRANT OPTION;
FLUSH PRIVILEGES;