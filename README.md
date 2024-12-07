# Stryker.NET Demo

Trying to understand the `--since` and `--baseline` features...

The config file has:

```json
    "since": {
      "enabled": true,
      "ignore-changes-in": [],
      "target": "v1"
    },
```

There is a tag `v1`.

I was expecting that the report is empty, because no new code was added after the `v1` tag commit.
