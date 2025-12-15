const path = require("path")
const mixinsPath = path
  .join(__dirname, "styles", "mixins.scss")
  .replace(/\\/g, "/")

module.exports = {
  sassOptions: {
    includePaths: [path.join(__dirname, "styles")],
    additionalData: `@use "${mixinsPath}" as *;`,
  },
}
