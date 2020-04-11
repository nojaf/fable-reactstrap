// Note this only includes basic configuration for development mode.
// For a more comprehensive configuration check:
// https://github.com/fable-compiler/webpack-config-template

const path = require("path");
const HtmlWebpackPlugin = require("html-webpack-plugin");
const MiniCssExtractPlugin = require("mini-css-extract-plugin");
const CopyWebpackPlugin = require("copy-webpack-plugin");

function resolve(filePath) {
  return path.join(__dirname, filePath);
}

const babel = {
  plugins: ["@babel/plugin-syntax-dynamic-import"]
};

const isProduction = process.argv.indexOf("-p") >= 0;
console.log(
    "Bundling for " + (isProduction ? "production" : "development") + "..."
);

module.exports = {
  mode: "development",
  entry: "./documentation/Entry.fsx",
  output: {
    path: path.join(__dirname, "./docs"),
    filename: "[name].bundle.js",
    chunkFilename: "[name].bundle.js",
    publicPath: isProduction ? "/fable-reactstrap/" : "/"
  },
  devServer: {
    contentBase: "./documentation/public",
    port: 8080,
    historyApiFallback: true
  },
  module: {
    rules: [
      {
        test: /\.fs(x|proj)?$/,
        use: {
          loader: "fable-loader",
          options: {
            babel
          }
        }
      },
      {
        test: /\.(sass|css)$/,
        use: [
          isProduction ? MiniCssExtractPlugin.loader : "style-loader",
          "css-loader",
          "sass-loader"
        ]
      }
    ]
  },
  externals: {
    react: "React",
    "react-dom": "ReactDOM"
  },
  optimization: {
    splitChunks: {
      chunks: "all"
    }
  },
  plugins: isProduction?  [
    new CopyWebpackPlugin([{ from: resolve("./documentation/public") }]),
    new MiniCssExtractPlugin({ filename: "style.css" }),
    new HtmlWebpackPlugin({
      filename: "index.html",
      template: "./documentation/public/index.html"
    })
  ] : [
    new HtmlWebpackPlugin({
      filename: "index.html",
      template: "./documentation/public/index.html"
    })
  ]
};
