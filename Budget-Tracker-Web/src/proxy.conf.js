const PROXY_CONFIG = [
  {
    context: [
      "transaction",
    ],
    target: "https://localhost:5074",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
