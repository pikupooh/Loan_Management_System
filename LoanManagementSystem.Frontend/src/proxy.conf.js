const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
    ],
    target: "https://localhost:7061;http://localhost:5061",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
