// vue.config.js

module.exports = {
  outputDir: './wwwroot/',
  filenameHashing: false,

  pluginOptions: {
    sourceDir: 'src'
  },

  configureWebpack: {

    optimization: {
      splitChunks: false
    },

    output: {
      filename: 'app.js'
    },
    devtool: 'source-map',
    resolve: {
      alias: {
        '@': 'C:\\Code\\MyClientWeb2\\MyClientWeb2\\src',
        vue$: 'vue/dist/vue.runtime.esm.js'
      }
    }
  },

  productionSourceMap: false
}
