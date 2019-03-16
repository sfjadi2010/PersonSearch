FROM microsoft/dotnet:latest

COPY ./enterypoint.sh /
RUN sed -i 's/\r//' /entrypoint.sh
RUN chmod +x /entrypoint.sh
WORKDIR /app

CMD /entrypoint.sh