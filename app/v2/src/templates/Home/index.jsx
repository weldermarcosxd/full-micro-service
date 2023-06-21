import './styles.css';

import { Component } from 'react';
import { loadPosts } from '../../utils/load-posts';
import { Posts } from '../../components/Posts';
import { Botao } from '../../components/Botao';
import { CaixaDeTexto } from '../../components/CaixaDeTexto';

class Home extends Component{

  state = {
    posts: [],
    allPosts: [],
    postsPerPage: 2,
    currentPage: 0,
    searchValue: ""
  }

  async componentDidMount(){
    await this.loadPosts(); 
  }

  loadPosts = async () => {
    const { currentPage, postsPerPage } = this.state;
    const postsAndPhostos = await loadPosts();
    this.setState({
      posts:  postsAndPhostos.slice(currentPage * postsPerPage,postsPerPage),
      allPosts:  postsAndPhostos 
    });
  }

  loadMorePosts = () => {
    const {currentPage, postsPerPage, allPosts, posts } = this.state;
    const nextPage = currentPage + postsPerPage;
    const nextPosts = allPosts.slice(nextPage, nextPage + postsPerPage);
    posts.push(...nextPosts);
    this.setState({posts, currentPage: nextPage});
  }

  handleChange = (e) => {
    const {value} = e.target;
    this.setState({ searchValue: value });
  }

  render() {
    const { posts, currentPage, postsPerPage, allPosts, searchValue } = this.state;
    const noMorePosts = currentPage + postsPerPage >= allPosts.length;

    return (
      <section className='container'>
        {!!searchValue && (
          <h1>{searchValue}</h1>
        )}
        <CaixaDeTexto onChange={this.handleChange} value={searchValue}></CaixaDeTexto>
        <Posts posts={posts}></Posts>
        {!searchValue && (
          <div className='button-container'>
          <Botao text="Loads" onClick={this.loadMorePosts} disabled={noMorePosts}></Botao>
        </div>
        )}
        
      </section>
    );
  }
}

export default Home;
