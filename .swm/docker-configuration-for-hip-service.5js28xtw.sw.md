---
title: Docker Configuration for hip-service
---
# Intro

This document explains how Docker is used in the hip-service project. It will cover the Docker configuration files and their respective steps.

<SwmSnippet path="/filebeat.Dockerfile" line="1">

---

## <SwmPath>[gatewayStubConfigurations/Dockerfile](gatewayStubConfigurations/Dockerfile)</SwmPath> Configuration

The <SwmPath>[filebeat.Dockerfile](filebeat.Dockerfile)</SwmPath> is used to build the Filebeat service image. It starts with the base image from Elastic's Filebeat version <SwmToken path="filebeat.Dockerfile" pos="1:12:16" line-data="FROM docker.elastic.co/beats/filebeat:6.7.0">`6.7.0`</SwmToken>.

```dockerfile
FROM docker.elastic.co/beats/filebeat:6.7.0
```

---

</SwmSnippet>

<SwmSnippet path="/filebeat.Dockerfile" line="2">

---

## Copying Configuration File

The configuration file <SwmPath>[filebeat/filebeat.yml](filebeat/filebeat.yml)</SwmPath> is copied to the appropriate directory in the container.

```dockerfile
COPY filebeat/filebeat.yml /usr/share/filebeat/filebeat.yml
```

---

</SwmSnippet>

<SwmSnippet path="/filebeat.Dockerfile" line="3">

---

## Setting Permissions

The permissions for the <SwmPath>[filebeat/filebeat.yml](filebeat/filebeat.yml)</SwmPath> file are set to ensure it is owned by the root user and the filebeat group, and the file permissions are set to 644.

```dockerfile
USER root
RUN chown root:filebeat /usr/share/filebeat/filebeat.yml
RUN chmod 644 /usr/share/filebeat/filebeat.yml
```

---

</SwmSnippet>

<SwmSnippet path="/filebeat.Dockerfile" line="6">

---

## Running as Filebeat User

The container switches to the <SwmToken path="filebeat.Dockerfile" pos="6:2:2" line-data="USER filebeat">`filebeat`</SwmToken> user to run the service.

```dockerfile
USER filebeat
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="1">

---

## Docker Compose Configuration

The <SwmPath>[docker-compose.yml](docker-compose.yml)</SwmPath> file defines the services and their configurations for the hip-service project. It starts by specifying the version of Docker Compose.

```yaml
version: '3'
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="3">

---

## HIP Service Configuration

The <SwmToken path="docker-compose.yml" pos="3:1:1" line-data="  hip:">`hip`</SwmToken> service is defined with its build context, port mapping, dependencies, and environment variables.

```yaml
  hip:
    build: .
    ports:
      - "9052:80"
    depends_on:
      - db
      - rabbitmq
      - otp
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

The <SwmToken path="docker-compose.yml" pos="15:1:1" line-data="  otp:">`otp`</SwmToken> service uses a pre-built image, specifies its dependencies, environment variables, and port mapping.

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

<SwmSnippet path="/docker-compose.yml" line="23">

---

## Gateway Service Configuration

The <SwmToken path="docker-compose.yml" pos="23:1:1" line-data="  gateway:">`gateway`</SwmToken> service is built from a specific directory and maps its ports.

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

The <SwmToken path="docker-compose.yml" pos="28:1:5" line-data="  oidc-server-mock:">`oidc-server-mock`</SwmToken> service uses a pre-built image, maps its ports, and sets environment variables for API scopes and client configurations.

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

The <SwmToken path="docker-compose.yml" pos="41:1:1" line-data="  db:">`db`</SwmToken> service uses the latest PostgreSQL image, sets environment variables for the database user and password, maps its ports, and defines volume mappings.

```yaml
  db:
    image: "postgres:latest"
    environment:
      - POSTGRES_USER=postgres
      - POSTGRES_PASSWORD=welcome
    ports:
      - "5432:5432"
    volumes:
      - postgresql:/var/lib/postgresql
      - postgresql_data:/var/lib/postgresql/data
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="51">

---

## RabbitMQ Service Configuration

The <SwmToken path="docker-compose.yml" pos="51:1:1" line-data="  rabbitmq:">`rabbitmq`</SwmToken> service uses the RabbitMQ image and maps its ports.

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

The <SwmToken path="docker-compose.yml" pos="55:1:1" line-data="  filebeat:">`filebeat`</SwmToken> service is built using the <SwmPath>[filebeat.Dockerfile](filebeat.Dockerfile)</SwmPath>, maps volumes, and connects to the <SwmToken path="docker-compose.yml" pos="63:3:3" line-data="      - elk">`elk`</SwmToken> network.

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

The <SwmToken path="docker-compose.yml" pos="64:1:1" line-data="  logstash:">`logstash`</SwmToken> service is built from the <SwmToken path="docker-compose.yml" pos="64:1:1" line-data="  logstash:">`logstash`</SwmToken> directory, maps configuration and pipeline volumes, sets environment variables, and connects to the <SwmToken path="docker-compose.yml" pos="75:3:3" line-data="      - elk">`elk`</SwmToken> network.

```yaml
  logstash:
    build:
      context: logstash/
    volumes:
      - ./logstash/config/logstash.yml:/usr/share/logstash/config/logstash.yml:ro
      - ./logstash/pipeline:/usr/share/logstash/pipeline:ro
    ports:
      - "5044:5044"
    environment:
      LS_JAVA_OPTS: "-Xmx256m -Xms256m"
    networks:
      - elk
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="77">

---

## Volume Configuration

The volumes for PostgreSQL data are defined at the end of the file.

```yaml
volumes:
  postgresql:
  postgresql_data:
```

---

</SwmSnippet>

<SwmSnippet path="/docker-compose.yml" line="81">

---

## Network Configuration

The <SwmToken path="docker-compose.yml" pos="82:1:1" line-data="  elk:">`elk`</SwmToken> network is defined as an external network.

```yaml
networks:
  elk:
    external: true
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
