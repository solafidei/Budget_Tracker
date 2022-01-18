const PROXY_CONFIG = [
  {
    context: [
      "/api/transaction",
      "/api/account",
      "/api/bank",
      "/api/product"
    ],
    target: "https://localhost:5075",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
