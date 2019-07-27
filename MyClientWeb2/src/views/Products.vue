<template>
  <div class="products">
    <wait-cursor
      message="Getting Products ..."
      :busy="isBusy"
    />
    <h1>This is a {{ appName }}</h1>
    <button @click="getProducts()">
      Get Products
    </button>
    <h3>{{ error }}</h3>
    <h3>Products ...</h3>
    <ul>
      <li
        v-for="product in products"
        :key="product"
      >
        {{ product.name }}
      </li>
    </ul>
  </div>
</template>

<script>
import axios from 'axios'
import WaitCursor from '@/components/WaitCursor.vue'

export default {
  name: 'Products',
  components: {
    WaitCursor
  },
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
      axios.get('http://localhost:8081/api/products')
        .then((response) => {
          this.isBusy = false
          this.products = response.data
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
