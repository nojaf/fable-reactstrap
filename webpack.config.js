// Note this only includes basic configuration for development mode.
// For a more comprehensive configuration check:
// https://github.com/fable-compiler/webpack-config-template

var path = require("path");

module.exports = {
    mode: "development",
    entry: "./playground/Script.fsx",
    output: {
        path: path.join(__dirname, "./playground"),
        filename: "bundle.js"
    },
    devServer: {
        contentBase: "./playground",
        port: 8080
    },
    module: {
        rules: [{
            test: /\.fs(x|proj)?$/,
            use: "fable-loader"
        },
            {
                test: /\.sass$/,
                use: [
                    "style-loader", // creates style nodes from JS strings
                    "css-loader", // translates CSS into CommonJS
                    "sass-loader" // compiles Sass to CSS, using Node Sass by default
                ]
            }]
    },
    externals: {
        'react': 'React',
        'react-dom': 'ReactDOM'
    }
};