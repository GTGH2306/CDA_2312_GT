FROM debian:bookworm

RUN apt update
RUN apt install -y apache2

WORKDIR /var/www/html

RUN rm ./index.html

COPY ./ ./

EXPOSE 80

ENTRYPOINT apache2ctl -D FOREGROUND