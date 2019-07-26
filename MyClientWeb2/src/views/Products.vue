<template>
  <div class="products">
    <h1>This is a {{ appName }}</h1>
  </div>
</template>

<script>
import axios from 'axios'
export default {
  data () {
    return {
      appName: 'Products page',
      error: '',
      isBusy: false,
      products: []
    }
  },
  methods: {
    getProducts: function () {
      this.error = ''
      this.isBusy = true
      axios.get('/api/products')
        .then((response) => {
          this.isBusy = false
          this.products = response.data.value
        }, (error) => {
          this.isBusy = false
          this.error = error
        })
    }
  },
  mounted () {
  },
  computed: {
  }
}
</script>
