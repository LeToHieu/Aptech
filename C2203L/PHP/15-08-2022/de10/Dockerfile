FROM php:zts-alpine3.16
WORKDIR /code
# RUN apk add --no-cache gcc musl-dev linux-headers
EXPOSE 8080
COPY . .
CMD ["php -S localhost:8080 -t ."]