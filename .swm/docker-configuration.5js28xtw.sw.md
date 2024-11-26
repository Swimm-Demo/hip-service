---
title: 'Docker Configuration '
---
# Intro

This document explains how Docker is used in the hip-service project. It will cover the Docker configuration files and their respective steps.

<SwmSnippet path="/docker-compose.yml" line="1">

---

## Docker Compose Configuration

The <SwmPath>[docker-compose.yml](docker-compose.yml)</SwmPath> file defines the services, networks, and volumes required for the application. It starts by specifying the version of Docker Compose being used.

```yaml
version: '3'
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="3">

---

## HIP Service Configuration

The <SwmToken path="docker-compose.yml" pos="3:1:1" line-data="  hip:">`hip`</SwmToken> service is defined with a build context set to the current directory. It maps port 9052 on the host to port 80 in the container and depends on the <SwmToken path="docker-compose.yml" pos="8:3:3" line-data="      - db">`db`</SwmToken>, <SwmToken path="docker-compose.yml" pos="9:3:3" line-data="      - rabbitmq">`rabbitmq`</SwmToken>, and <SwmToken path="docker-compose.yml" pos="10:3:3" line-data="      - otp">`otp`</SwmToken> services.

```yaml
  hip:
    build: .
    ports:
      - "9052:80"
    depends_on:
      - db
      - rabbitmq
      - otp
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="11">

---

## HIP Service Environment Variables

Environment variables for the <SwmToken path="docker-compose.yml" pos="3:1:1" line-data="  hip:">`hip`</SwmToken> service are defined, including <SwmToken path="docker-compose.yml" pos="12:3:3" line-data="      - HEALTH_CHECK_DURATION=5000">`HEALTH_CHECK_DURATION`</SwmToken>, <SwmToken path="docker-compose.yml" pos="13:3:5" line-data="      - Gateway:clientSecret=93ef283e-1968-46ab-8731-cfccda83680a">`Gateway:clientSecret`</SwmToken>, and <SwmToken path="docker-compose.yml" pos="14:3:5" line-data="      - OpenMrs:url=$BAHMNI_URL">`OpenMrs:url`</SwmToken>.

```yaml
    environment: 
      - HEALTH_CHECK_DURATION=5000
      - Gateway:clientSecret=93ef283e-1968-46ab-8731-cfccda83680a
      - OpenMrs:url=$BAHMNI_URL
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="15">

---

## OTP Service Configuration

The <SwmToken path="docker-compose.yml" pos="15:1:1" line-data="  otp:">`otp`</SwmToken> service uses the <SwmToken path="docker-compose.yml" pos="16:5:9" line-data="    image: &quot;ganesan92/otp-service&quot;">`ganesan92/otp-service`</SwmToken> image, depends on the <SwmToken path="docker-compose.yml" pos="18:3:3" line-data="      - db">`db`</SwmToken> service, and maps port 5000 on the host to port 80 in the container.

```yaml
  otp:
    image: "ganesan92/otp-service"
    depends_on:
      - db
    environment:
      "ConnectionStcrings:DefaultConnection": "Host=postgres;Port=5432;Username=postgres;Password=password;Database=otpservice;"
    ports:
      - "5000:80"
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="19">

---

## OTP Service Environment Variables

Environment variables for the <SwmToken path="docker-compose.yml" pos="10:3:3" line-data="      - otp">`otp`</SwmToken> service are defined, including the connection string for the database.

```yaml
    environment:
      "ConnectionStcrings:DefaultConnection": "Host=postgres;Port=5432;Username=postgres;Password=password;Database=otpservice;"
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="23">

---

## Gateway Service Configuration

The <SwmToken path="docker-compose.yml" pos="23:1:1" line-data="  gateway:">`gateway`</SwmToken> service is built from the <SwmToken path="docker-compose.yml" pos="24:4:4" line-data="    build: gatewayStubConfigurations/.">`gatewayStubConfigurations`</SwmToken> directory and maps ports 2525 and 8000 on the host to the container.

```yaml
  gateway:
    build: gatewayStubConfigurations/.
    ports:
      - "2525:2525"
      - "8000:8000"
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="28">

---

## OIDC Server Mock Configuration

The <SwmToken path="docker-compose.yml" pos="28:1:5" line-data="  oidc-server-mock:">`oidc-server-mock`</SwmToken> service uses the <SwmToken path="docker-compose.yml" pos="29:4:10" line-data="    image: soluto/oidc-server-mock">`soluto/oidc-server-mock`</SwmToken> image, maps port 8080 on the host to port 80 in the container, and defines environment variables for API scopes and client configuration.

```yaml
  oidc-server-mock:
    image: soluto/oidc-server-mock
    ports:
      - "8080:80"
    container_name: oidc-server-mock
    environment:
      API_SCOPES_INLINE: |
        [
          { "Name": "some-app-scope-1" }
        ]
      CLIENTS_CONFIGURATION_PATH: /gatewayStubConfigurations/oicdConfigs/clients-config.json
    volumes:
      - ./gatewayStubConfigurations/oicdConfigs/clients-config.json:/gatewayStubConfigurations/oicdConfigs/clients-config.json
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="41">

---

## Database Service Configuration

The <SwmToken path="docker-compose.yml" pos="41:1:1" line-data="  db:">`db`</SwmToken> service uses the <SwmToken path="docker-compose.yml" pos="42:5:7" line-data="    image: &quot;postgres:latest&quot;">`postgres:latest`</SwmToken> image, maps port 5432 on the host to the container, and defines environment variables for the PostgreSQL user and password.

```yaml
  db:
    image: "postgres:latest"
    environment:
      - POSTGRES_USER=postgres
      - POSTGRES_PASSWORD=welcome
    ports:
      - "5432:5432"
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="48">

---

## Database Service Volumes

Volumes for the <SwmToken path="docker-compose.yml" pos="8:3:3" line-data="      - db">`db`</SwmToken> service are defined to persist data in the PostgreSQL container.

```yaml
    volumes:
      - postgresql:/var/lib/postgresql
      - postgresql_data:/var/lib/postgresql/data
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="51">

---

## RabbitMQ Service Configuration

The <SwmToken path="docker-compose.yml" pos="51:1:1" line-data="  rabbitmq:">`rabbitmq`</SwmToken> service uses the <SwmToken path="docker-compose.yml" pos="52:5:7" line-data="    image: &quot;rabbitmq:3&quot;">`rabbitmq:3`</SwmToken> image and maps port 5672 on the host to the container.

```yaml
  rabbitmq:
    image: "rabbitmq:3"
    ports:
      - "5672:5672"
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="55">

---

## Filebeat Service Configuration

The <SwmToken path="docker-compose.yml" pos="55:1:1" line-data="  filebeat:">`filebeat`</SwmToken> service is built using the <SwmPath>[filebeat.Dockerfile](filebeat.Dockerfile)</SwmPath>, maps the <SwmToken path="docker-compose.yml" pos="61:3:4" line-data="      - ./logs:/var/log">`./logs`</SwmToken> directory to `/var/log` in the container, and connects to the <SwmToken path="docker-compose.yml" pos="63:3:3" line-data="      - elk">`elk`</SwmToken> network.

```yaml
  filebeat:
    container_name: filebeat
    build:
      context: .
      dockerfile: filebeat.Dockerfile
    volumes:
      - ./logs:/var/log
    networks:
      - elk
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="64">

---

## Logstash Service Configuration

The <SwmToken path="docker-compose.yml" pos="64:1:1" line-data="  logstash:">`logstash`</SwmToken> service is built from the <SwmToken path="docker-compose.yml" pos="64:1:1" line-data="  logstash:">`logstash`</SwmToken> directory, maps configuration and pipeline files, and maps port 5044 on the host to the container.

```yaml
  logstash:
    build:
      context: logstash/
    volumes:
      - ./logstash/config/logstash.yml:/usr/share/logstash/config/logstash.yml:ro
      - ./logstash/pipeline:/usr/share/logstash/pipeline:ro
    ports:
      - "5044:5044"
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="72">

---

## Logstash Service Environment Variables

Environment variables for the <SwmToken path="docker-compose.yml" pos="64:1:1" line-data="  logstash:">`logstash`</SwmToken> service are defined, including Java options.

```yaml
    environment:
      LS_JAVA_OPTS: "-Xmx256m -Xms256m"
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="77">

---

## Volumes Configuration

Volumes for the <SwmToken path="docker-compose.yml" pos="78:1:1" line-data="  postgresql:">`postgresql`</SwmToken> and <SwmToken path="docker-compose.yml" pos="79:1:1" line-data="  postgresql_data:">`postgresql_data`</SwmToken> are defined at the end of the file.

```yaml
volumes:
  postgresql:
  postgresql_data:
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="81">

---

## Networks Configuration

The <SwmToken path="docker-compose.yml" pos="82:1:1" line-data="  elk:">`elk`</SwmToken> network is defined as an external network.

```yaml
networks:
  elk:
    external: true
```

---

</SwmSnippet>

<SwmSnippet path="/filebeat.Dockerfile" line="1">

---

## Filebeat <SwmPath>[gatewayStubConfigurations/Dockerfile](gatewayStubConfigurations/Dockerfile)</SwmPath> Configuration

The <SwmPath>[filebeat.Dockerfile](filebeat.Dockerfile)</SwmPath> starts with the <SwmToken path="filebeat.Dockerfile" pos="1:2:16" line-data="FROM docker.elastic.co/beats/filebeat:6.7.0">`docker.elastic.co/beats/filebeat:6.7.0`</SwmToken> base image and copies the <SwmPath>[filebeat/filebeat.yml](filebeat/filebeat.yml)</SwmPath> configuration file to the container.

```dockerfile
FROM docker.elastic.co/beats/filebeat:6.7.0
COPY filebeat/filebeat.yml /usr/share/filebeat/filebeat.yml
```

---

</SwmSnippet>

<SwmSnippet path="/filebeat.Dockerfile" line="3">

---

## Filebeat <SwmPath>[gatewayStubConfigurations/Dockerfile](gatewayStubConfigurations/Dockerfile)</SwmPath> Permissions

The <SwmPath>[filebeat.Dockerfile](filebeat.Dockerfile)</SwmPath> sets the owner and permissions for the <SwmPath>[filebeat/filebeat.yml](filebeat/filebeat.yml)</SwmPath> file and switches the user to <SwmToken path="filebeat.Dockerfile" pos="4:6:6" line-data="RUN chown root:filebeat /usr/share/filebeat/filebeat.yml">`filebeat`</SwmToken>.

```dockerfile
USER root
RUN chown root:filebeat /usr/share/filebeat/filebeat.yml
RUN chmod 644 /usr/share/filebeat/filebeat.yml
USER filebeat
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
